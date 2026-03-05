namespace AirportTests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_laba3.classes;
using OOP_laba3.services;


[TestClass]
public class AbstractFactoryComparisonTests
{
    private readonly AbstractFactory _random = new RandomAbstractFactory();
    private readonly AbstractFactory _premium = new PremiumAbstractFactory();

    [TestMethod]
    public void PremiumAirport_HasHigherMinBalanceThanRandom()
    {
        decimal premiumBalance = _premium.CreateAirport().Balance;
        decimal randomMaxBalance = 1_000_000m;
        Assert.IsTrue(premiumBalance > randomMaxBalance,
            "Премиум баланс должен превышать максимальный баланс обычного аэропорта");
    }

    [TestMethod]
    public void PremiumAirplane_HasHigherMinRangeThanRandom()
    {
        double premiumRange = _premium.CreateAirplane().RangeKm;
        double randomMaxRange = 8_000;
        Assert.IsTrue(premiumRange > randomMaxRange,
            "Дальность премиум самолёта должна превышать максимальную дальность обычного");
    }

    [TestMethod]
    public void PremiumAirport_HasHigherRatingFloor()
    {
        for (int i = 0; i < 30; i++)
        {
            double premiumRating = _premium.CreateAirport().Rating;
            double randomRating = _random.CreateAirport().Rating;
            Assert.IsTrue(premiumRating >= 4.5,
                $"Премиум рейтинг {premiumRating} ниже 4.5");
            Assert.IsTrue(randomRating <= 5.0,
                $"Обычный рейтинг {randomRating} выше 5.0");
        }
    }

    [TestMethod]
    public void BothFactories_CreateDistinctObjectsEachCall()
    {
        Airport a1 = _random.CreateAirport();
        Airport a2 = _random.CreateAirport();
        Assert.AreNotSame(a1, a2);
        
        Airport premiumA1 = _premium.CreateAirport();
        Airport premiumA2 = _premium.CreateAirport();
        Assert.AreNotSame(premiumA1, premiumA2);
    }
}