/* VelociWrapTest.cs
 * Modified by: Dacey Simpson
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            VelociWrap vc = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vc.Description);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            VelociWrap vc = new VelociWrap();
            Assert.Empty(vc.Special);
        }

        [Fact]
        public void HoldDressingShouldAddToSpecial()
        {
            VelociWrap vc = new VelociWrap();
            vc.HoldDressing();
            Assert.Collection<string>(vc.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                });
        }

        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            VelociWrap vc = new VelociWrap();
            vc.HoldLettuce();
            Assert.Collection<string>(vc.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                });
        }

        [Fact]
        public void HoldCheeseShouldAddToSpecial()
        {
            VelociWrap vc = new VelociWrap();
            vc.HoldCheese();
            Assert.Collection<string>(vc.Special,
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                });
        }

        [Fact]
        public void HoldDressingLettuceAndCheeseShouldAddToSpecial()
        {
            VelociWrap vc = new VelociWrap();
            vc.HoldDressing();
            vc.HoldLettuce();
            vc.HoldCheese();
            Assert.Collection<string>(vc.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                });
        }

        [Fact]
        public void HoldingDressingShouldNotifySpecialChange()
        {
            VelociWrap vc = new VelociWrap();
            Assert.PropertyChanged(vc, "Special", () =>
            {
                vc.HoldDressing();
            });
        }

        [Fact]
        public void HoldingLettuceShouldNotifySpecialChange()
        {
            VelociWrap vc = new VelociWrap();
            Assert.PropertyChanged(vc, "Special", () =>
            {
                vc.HoldLettuce();
            });
        }

        [Fact]
        public void HoldingCheeseShouldNotifySpecialChange()
        {
            VelociWrap vc = new VelociWrap();
            Assert.PropertyChanged(vc, "Special", () =>
            {
                vc.HoldCheese();
            });
        }
    }
}
