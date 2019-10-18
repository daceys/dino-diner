/* TyrannoteaTest.cs
 * Author: Dacey Simpson
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //The correct default price, calories, ice, size, lemon, and sweet properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }
        [Fact]
        public void ShouldHaveDefaultNoLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }
        [Fact]
        public void ShouldHaveDefaultNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }
        //That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterAddingSweetSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterAddingSweetMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterAddingSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }
        //That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterRemovingSweetSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Sweet = false;
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterRemovingSweetMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Sweet = false;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterRemovingSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.Sweet = false;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
        }
        [Fact]
        public void ShouldHaveCorrectIngredientsWhenAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
        }
        [Fact]
        public void ShouldHaveCorrectIngredientsWhenSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldBeCorrect(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            Assert.Equal(size + " Tyrannotea", tea.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionforSweetShouldBeCorrect(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = true;
            Assert.Equal(size + " Sweet Tyrannotea", tea.Description);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }

        [Fact]
        public void AddingLemonShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void HoldingIceShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyPriceChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyCalorieChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyDescriptionChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Size = size;
            });
        }

        [Fact]
        public void AddingLemonShouldNotifySpecialChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            });
        }
    }
}
