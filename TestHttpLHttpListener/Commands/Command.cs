using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHttpLHttpListener.Commands
{
    public abstract class Command : ICommand
    {
        public bool IsCompleted { get; private set; }

        public event EventHandler Completed;
        public event EventHandler Failed;

        public abstract void Execute();

        public virtual void Stop()
        {
        }

        protected void OnCompleted()
        {
            IsCompleted = true;
            Completed?.Invoke(this, EventArgs.Empty);
        }

        protected void OnFailed()
        {
            Failed?.Invoke(this, EventArgs.Empty);
        }
    }
}
