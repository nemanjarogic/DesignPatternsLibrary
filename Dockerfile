FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy the solution file
COPY src/DesignPatternsLibrary.sln .

# Copy the main project file
COPY src/DesignPatternsLibrary/DesignPatternsLibrary.csproj DesignPatternsLibrary/

# Copy referenced projects' CSPROJ files
COPY ["src/AdditionalPatterns/EventAggregator/StoreManagement/StoreManagement.csproj", "AdditionalPatterns/EventAggregator/StoreManagement/"]
COPY ["src/BuildingBlocks/BuildingBlocks.csproj", "BuildingBlocks/"]
COPY ["src/AdditionalPatterns/FluentInterface/FluentInterfaceLibrary/FluentInterfaceLibrary.csproj", "AdditionalPatterns/FluentInterface/FluentInterfaceLibrary/"]
COPY ["src/AdditionalPatterns/Interpreter/InterpreterLibrary/InterpreterLibrary.csproj", "AdditionalPatterns/Interpreter/InterpreterLibrary/"]
COPY ["src/AdditionalPatterns/LazyLoad/LazyLoadLibrary/LazyLoadLibrary.csproj", "AdditionalPatterns/LazyLoad/LazyLoadLibrary/"]
COPY ["src/AdditionalPatterns/NullObject/NullObjectLibrary/NullObjectLibrary.csproj", "AdditionalPatterns/NullObject/NullObjectLibrary/"]
COPY ["src/AdditionalPatterns/Repository/OrderManagement/OrderManagement.csproj", "AdditionalPatterns/Repository/OrderManagement/"]
COPY ["src/AdditionalPatterns/Rules/RulesLibrary/RulesLibrary.csproj", "AdditionalPatterns/Rules/RulesLibrary/"]
COPY ["src/AdditionalPatterns/ServiceLocator/OrderProcessing/OrderProcessing.csproj", "AdditionalPatterns/ServiceLocator/OrderProcessing/"]
COPY ["src/AdditionalPatterns/Specification/ProductSpecification/ProductSpecification.csproj", "AdditionalPatterns/Specification/ProductSpecification/"]
COPY ["src/AdditionalPatterns/UnitOfWork/UnitOfWorkLibrary/UnitOfWorkLibrary.csproj", "AdditionalPatterns/UnitOfWork/UnitOfWorkLibrary/"]
COPY ["src/BehavioralPatterns/ChainOfResponsibility/ChainOfResponsibilityLibrary/ChainOfResponsibilityLibrary.csproj", "BehavioralPatterns/ChainOfResponsibility/ChainOfResponsibilityLibrary/"]
COPY ["src/BehavioralPatterns/Command/CommandLibrary/CommandLibrary.csproj", "BehavioralPatterns/Command/CommandLibrary/"]
COPY ["src/BehavioralPatterns/Iterator/IteratorLibrary/IteratorLibrary.csproj", "BehavioralPatterns/Iterator/IteratorLibrary/"]
COPY ["src/BehavioralPatterns/Mediator/MediatorLibrary/MediatorLibrary.csproj", "BehavioralPatterns/Mediator/MediatorLibrary/"]
COPY ["src/BehavioralPatterns/Memento/MementoLibrary/MementoLibrary.csproj", "BehavioralPatterns/Memento/MementoLibrary/"]
COPY ["src/BehavioralPatterns/Observer/ObserverLibrary/ObserverLibrary.csproj", "BehavioralPatterns/Observer/ObserverLibrary/"]
COPY ["src/BehavioralPatterns/State/StateLibrary/StateLibrary.csproj", "BehavioralPatterns/State/StateLibrary/"]
COPY ["src/BehavioralPatterns/Strategy/StrategyLibrary/StrategyLibrary.csproj", "BehavioralPatterns/Strategy/StrategyLibrary/"]
COPY ["src/BehavioralPatterns/TemplateMethod/TemplateMethodLibrary/TemplateMethodLibrary.csproj", "BehavioralPatterns/TemplateMethod/TemplateMethodLibrary/"]
COPY ["src/BehavioralPatterns/Visitor/VisitorLibrary/VisitorLibrary.csproj", "BehavioralPatterns/Visitor/VisitorLibrary/"]
COPY ["src/CreationalPatterns/AbstractFactory/MealSimpleFactory/MealSimpleFactory.csproj", "CreationalPatterns/AbstractFactory/MealSimpleFactory/"]
COPY ["src/CreationalPatterns/AbstractFactory/RestaurantAbstractFactory/RestaurantAbstractFactory.csproj", "CreationalPatterns/AbstractFactory/RestaurantAbstractFactory/"]
COPY ["src/CreationalPatterns/Builder/CustomSandwichBuilder/CustomSandwichBuilder.csproj", "CreationalPatterns/Builder/CustomSandwichBuilder/"]
COPY ["src/CreationalPatterns/FactoryMethod/RestaurantManagement/RestaurantManagement.csproj", "CreationalPatterns/FactoryMethod/RestaurantManagement/"]
COPY ["src/CreationalPatterns/Prototype/PrototypeLibrary/PrototypeLibrary.csproj", "CreationalPatterns/Prototype/PrototypeLibrary/"]
COPY ["src/CreationalPatterns/Singleton/Greeter/Greeter.csproj", "CreationalPatterns/Singleton/Greeter/"]
COPY ["src/StructuralPatterns/Adapter/AdapterLibrary/AdapterLibrary.csproj", "StructuralPatterns/Adapter/AdapterLibrary/"]
COPY ["src/StructuralPatterns/Bridge/BridgeLibrary/BridgeLibrary.csproj", "StructuralPatterns/Bridge/BridgeLibrary/"]
COPY ["src/StructuralPatterns/Composite/CompositeLibrary/CompositeLibrary.csproj", "StructuralPatterns/Composite/CompositeLibrary/"]
COPY ["src/StructuralPatterns/Decorator/DecoratorLibrary/DecoratorLibrary.csproj", "StructuralPatterns/Decorator/DecoratorLibrary/"]
COPY ["src/StructuralPatterns/Facade/FacadeLibrary/FacadeLibrary.csproj", "StructuralPatterns/Facade/FacadeLibrary/"]
COPY ["src/StructuralPatterns/Flyweight/FlyweightLibrary/FlyweightLibrary.csproj", "StructuralPatterns/Flyweight/FlyweightLibrary/"]
COPY ["src/StructuralPatterns/Proxy/ProxyLibrary/ProxyLibrary.csproj", "StructuralPatterns/Proxy/ProxyLibrary/"]

# Restore the NuGet packages for the entire solution
RUN dotnet restore

# Copy the source code for the entire solution
COPY src/ .

# Build and publish the main project
RUN dotnet publish DesignPatternsLibrary/DesignPatternsLibrary.csproj -c Release -o /app/publish

# Generate the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DesignPatternsLibrary.dll"]