using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Logic.Business.Workflows.Contract;

public interface IPersonAddWorkflow
{
    void Run(Person person);
}