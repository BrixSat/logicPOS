using System;

namespace logicpos.licencemanager.plugin
{
    public interface IPlugin
    {
        string Name { get; }
        Type BaseType { get; }
        Type Interface { get ; }
        void Do();
    }
}
