using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SteamDegreesOfSeparation
{
	public class SteamFriendsQuarry
	{
		public QuarryStatus CurrentStatus { get; private set; } = QuarryStatus.Stopped;
		public int TargetThreadsAmount { get; private set; } = 4;

		public event EventHandler ThreadsStarted = delegate { };

		private List<Thread> threads = new List<Thread>();
		private ManualResetEvent threadsPause = new ManualResetEvent(true);
		private CancellationToken cancelToken;
		private CancellationTokenSource cancelSource;

		public void SetTargetThreadsAmount(int newAmount)
		{
			if (CurrentStatus != QuarryStatus.Stopped)
			{
				throw new InvalidOperationException("Quarry has to be stopped first!");
			}

			if (newAmount <= 0)
			{
				throw new ArgumentException("Amount has to be greater than zero", nameof(newAmount));
			}

			TargetThreadsAmount = newAmount;
		}

		private void CreateThreads()
		{
			threads.Clear();

			for (int i = 0; i < TargetThreadsAmount; i++)
			{
				threads.Add(CreateBackgroundThread(i + 1));
			}
		}

		private Thread CreateBackgroundThread(int id)
		{
			Thread thread = new Thread(ThreadMethod);
			thread.IsBackground = true;
			thread.Name = "SteamFriendsQuarry bg worker #" + id;
			thread.Priority = ThreadPriority.BelowNormal;

			return thread;
		}

		private void ThreadMethod()
		{
			while (true)
			{
				threadsPause.WaitOne();
				if (cancelToken.IsCancellationRequested)
				{
					return;
				}

				Thread.Sleep(1);
				//TODO
			}
		}

		public async Task Start()
		{
			if (CurrentStatus == QuarryStatus.Stopped)
			{
				CurrentStatus = QuarryStatus.WarmingUp;

				cancelSource = new CancellationTokenSource();
				cancelToken = cancelSource.Token;

				// This process can possibly run a long time, so it will be run on a background thread.
				await Task.Run(() =>
				{
					CreateThreads();

					for (int i = 0; i < threads.Count; i++)
					{
						Thread th = threads[i];
						th.Start();
					}
				});

				CurrentStatus = QuarryStatus.Started;

				ThreadsStarted.Invoke(this, EventArgs.Empty);
			}
			else if (CurrentStatus == QuarryStatus.Paused)
			{
				threadsPause.Set();

				CurrentStatus = QuarryStatus.Started;
			}
			else
			{
				throw new InvalidOperationException("Quarry in this state cannot be started. Current state: " + CurrentStatus);
			}
		}

		public void Pause()
		{
			if (CurrentStatus == QuarryStatus.Started)
			{
				threadsPause.Reset();

				CurrentStatus = QuarryStatus.Paused;
			}
			else if (CurrentStatus == QuarryStatus.Paused)
			{
				//Do nothing
			}
			else
			{
				throw new InvalidOperationException("Quarry in this state cannot be paused. Current state: " + CurrentStatus);
			}
		}

		public void Stop()
		{
			if (CurrentStatus == QuarryStatus.Started)
			{
				RealyStop();

				CurrentStatus = QuarryStatus.Stopped;
			}
			else if (CurrentStatus == QuarryStatus.Paused)
			{
				threadsPause.Set();
				RealyStop();

				CurrentStatus = QuarryStatus.Stopped;
			}
			else
			{
				throw new InvalidOperationException("Quarry in this state cannot be stopped. Current state: " + CurrentStatus);
			}
		}

		private void RealyStop()
		{
			cancelSource.Cancel();

			threads.Clear();
		}
	}
}
