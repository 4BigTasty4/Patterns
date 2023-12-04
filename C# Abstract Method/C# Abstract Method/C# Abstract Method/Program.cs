using C__Abstract_Method.Entities.Classes.Engine;
using C__Abstract_Method.Entities.Classes.Tank;
using C__Abstract_Method.Entities.Interfaces;
using C__Abstract_Method.Factories.Classes;
using C__Abstract_Method.Factories.Interfaces;

IFactory heavyFactory = new HeavyTankFactory();

IEngine heavyEngine = heavyFactory.createEngine();

ITank heavyTank = heavyFactory.createTank();

heavyTank.TankCraft(heavyEngine);

IFactory mediumFactory = new MediumTankFactory();

IEngine mediumEngine = mediumFactory.createEngine();

ITank mediumTank  = mediumFactory.createTank();

mediumTank.TankCraft(mediumEngine);