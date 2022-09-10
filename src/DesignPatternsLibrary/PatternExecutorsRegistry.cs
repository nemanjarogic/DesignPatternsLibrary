using BuildingBlocks;

namespace DesignPatternsLibrary;

#nullable enable
public class PatternExecutorsRegistry
{
    private static PatternExecutorsRegistry? _instance;
    private readonly SortedDictionary<int, PatternExecutor> _executors;

    private PatternExecutorsRegistry()
    {
        var patternExecutors = new List<PatternExecutor>
        {
            new Greeter.Executor(),
            new RestaurantManagement.Executor(),
            new MealSimpleFactory.Executor(),
            new RestaurantAbstractFactory.Executor(),
            new CustomSandwichBuilder.Executor(),
            new PrototypeLibrary.Executor(),
            new AdapterLibrary.Executor(),
            new BridgeLibrary.Executor(),
            new CompositeLibrary.Executor(),
            new DecoratorLibrary.Executor(),
            new FacadeLibrary.Executor(),
            new FluentInterfaceLibrary.Executor(),
            new FlyweightLibrary.Executor(),
            new ProxyLibrary.Executor(),
            new ChainOfResponsibilityLibrary.Executor(),
            new CommandLibrary.Executor(),
            new IteratorLibrary.Executor(),
            new MediatorLibrary.Executor(),
            new MementoLibrary.Executor(),
            new ObserverLibrary.Executor(),
            new StateLibrary.Executor(),
            new StrategyLibrary.Executor(),
            new TemplateMethodLibrary.Executor(),
            new VisitorLibrary.Executor(),
            new StoreManagement.Executor(),
            new InterpreterLibrary.Executor(),
            new LazyLoadLibrary.Executor(),
            new NullObjectLibrary.Executor(),
            new OrderManagement.Executor(),
            new RulesLibrary.Executor(),
            new OrderProcessing.Executor(),
            new ProductSpecification.Executor(),
            new UnitOfWorkLibrary.Executor(),
        };

        var serialNumber = 1;
        _executors = new SortedDictionary<int, PatternExecutor>();

        foreach (var executor in patternExecutors.OrderBy(pattern => pattern.Name))
        {
            _executors.Add(serialNumber++, executor);
        }
    }

    public static PatternExecutorsRegistry Instance => _instance ??= new PatternExecutorsRegistry();

    public SortedDictionary<int, PatternExecutor> GetAll() => _executors;
}
