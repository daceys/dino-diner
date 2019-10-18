/* TRexKingBurgerTest.cs
 * Modified by: Dacey Simpson
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", tr.Description);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.Empty(tr.Special);
        }

        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldBun();
            Assert.Collection<string>(tr.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                });
        }

        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldLettuce();
            Assert.Collection<string>(tr.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                });
        }

        [Fact]
        public void HoldTomatoShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldTomato();
            Assert.Collection<string>(tr.Special,
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                });
        }

        [Fact]
        public void HoldOnionShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldOnion();
            Assert.Collection<string>(tr.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                });
        }

        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldPickle();
            Assert.Collection<string>(tr.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                });
        }

        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldKetchup();
            Assert.Collection<string>(tr.Special,
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                });
        }

        [Fact]
        public void HoldMustardShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldMustard();
            Assert.Collection<string>(tr.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                });
        }

        [Fact]
        public void HoldMayoShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldMayo();
            Assert.Collection<string>(tr.Special,
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                });
        }

        [Fact]
        public void HoldTomatoOnionAndPickleShouldAddToSpecial()
        {
            TRexKingBurger tr = new TRexKingBurger();
            tr.HoldTomato();
            tr.HoldOnion();
            tr.HoldPickle();
            Assert.Collection<string>(tr.Special,
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                });
        }

        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldBun();
            });
        }

        [Fact]
        public void HoldingLettuceShouldNotifySpecialChange()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldLettuce();
            });
        }

        [Fact]
        public void HoldingTomatoShouldNotifySpecialChange()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldTomato();
            });
        }

        [Fact]
        public void HoldingOnionShouldNotifySpecialChange()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldOnion();
            });
        }

        [Fact]
        public void HoldingPickleShouldNotifySpecialChange()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldPickle();
            });
        }

        [Fact]
        public void HoldingKetchupShouldNotifySpecialChange()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldKetchup();
            });
        }

        [Fact]
        public void HoldingMustardShouldNotifySpecialChange()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldMustard();
            });
        }

        [Fact]
        public void HoldingMayoShouldNotifySpecialChange()
        {
            TRexKingBurger tr = new TRexKingBurger();
            Assert.PropertyChanged(tr, "Special", () =>
            {
                tr.HoldMayo();
            });
        }
    }

}
