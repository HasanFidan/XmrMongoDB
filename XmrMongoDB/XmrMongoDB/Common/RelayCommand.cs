using System;
using System.ComponentModel;
using Xamarin.Forms;





namespace XmrMongoDB.Common
{
    public class RelayCommand : Command
    {
        
        public RelayCommand(Action<object> execute)
            : base(execute)
        {
        }

        public RelayCommand(Action execute)
                : this(o => execute())
            {
        }
    /// <summary>
    /// Creates a new command.
    /// </summary>
    /// <param name="execute">The execution logic.</param>
    /// <param name="canExecute">The execution status logic.</param>
    public RelayCommand(Action<object> execute, Func<object, bool> canExecute, INotifyPropertyChanged npc = null)
            :base(execute,canExecute)
        {
            //if (execute == null)
            //    throw new ArgumentNullException("execute");

            //_execute = execute;
            //_canExecute = canExecute;

            if (npc != null)
            {
                npc.PropertyChanged += delegate{ ChangeCanExecute(); };
            }
        }

        public RelayCommand(Action execute, Func<bool> canExecute, INotifyPropertyChanged npc = null)
             : this(o => execute(), o => canExecute(), npc)
        {
        }
        
     

       
        
    }
}


