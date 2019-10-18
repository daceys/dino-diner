/* SteakosaurusBurgerTest.cs
 * Modified by: Dacey Simpson
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", st.Description);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            Assert.Empty(st.Special);
        }

        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            st.HoldBun();
            Assert.Collection<string>(st.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                });
        }

        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            st.HoldPickle();
            Assert.Collection<string>(st.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                });
        }

        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            st.HoldKetchup();
            Assert.Collection<string>(st.Special,
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                });
        }

        [Fact]
        public void HoldMustardShouldAddToSpecial()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            st.HoldMustard();
            Assert.Collection<string>(st.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                });
        }

        [Fact]
        public void HoldPickleKetchupAndMustardShouldAddToSpecial()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            st.HoldPickle();
            st.HoldKetchup();
            st.HoldMustard();
            Assert.Collection<string>(st.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                });
        }

        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            Assert.PropertyChanged(st, "Special", () =>
            {
                st.HoldBun();
            });
        }

        [Fact]
        public void HoldingPickleShouldNotifySpecialChange()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            Assert.PropertyChanged(st, "Special", () =>
            {
                st.HoldPickle();
            });
        }

        [Fact]
        public void HoldingKetchupShouldNotifySpecialChange()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            Assert.PropertyChanged(st, "Special", () =>
            {
                st.HoldKetchup();
            });
        }

        [Fact]
        public void HoldingMustardShouldNotifySpecialChange()
        {
            SteakosaurusBurger st = new SteakosaurusBurger();
            Assert.PropertyChanged(st, "Special", () =>
            {
                st.HoldMustard();
            });
        }
    }

}
