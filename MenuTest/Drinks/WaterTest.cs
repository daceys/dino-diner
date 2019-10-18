/* WaterTest.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }
        [Fact]
        public void ShouldHaveDefaultNoLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }
        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
        }
        [Fact]
        public void ShouldHaveCorrectIngredientsWhenAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Contains<string>("Lemon", water.Ingredients);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldBeCorrect(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal(size + " Water", water.Description);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void AddingLemonShouldAddToSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void HoldingIceShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddingLemonShouldNotifySpecialChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            });
        }
    }
}
