using BridgeLibrary.ManuscriptsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.ManuscriptsAndFormattersExample.Manuscripts.Common
{
    public abstract class Manuscript
    {
        protected readonly IFormatter formatter;

        public Manuscript(IFormatter formatter)
        {
            this.formatter = formatter;
        }

        public abstract void Print();
    }
}
