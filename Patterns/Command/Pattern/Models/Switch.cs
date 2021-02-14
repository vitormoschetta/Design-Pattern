using Pattern.Interfaces;

namespace Pattern.Models
{
    public class Switch
    {
        ICommand _closedCommand;
        ICommand _openedCommand;

        public Switch(ICommand closedCommand, ICommand openedCommand)
        {
            this._closedCommand = closedCommand;
            this._openedCommand = openedCommand;
        }

        //fecha o circuito/liga
        public void Close()
        {
           this._closedCommand.Execute();
        }

        //abre o circuito/desliga
        public void Open()
        {
            this._openedCommand.Execute();
        }
    }
}