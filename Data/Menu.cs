/* Author: Riley Smith
 * Class name: Menu.cs
 * Purpose: Static class used to store instances of all menu items.
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// Static method for the entree items.
        /// </summary>
        /// <returns>A list of instances for the entrees.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());
            return list;
        }

        /// <summary>
        /// Static method for the side items.
        /// </summary>
        /// <returns>A list of instances for the sides.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size))) {
                list.Add(new DragonbornWaffleFries() { Size = size });
                list.Add(new FriedMiraak() { Size = size });
                list.Add(new MadOtarGrits() { Size = size });
                list.Add(new VokunSalad() { Size = size });
            }
            return list;
        }

        /// <summary>
        /// Static method for the drink items.
        /// </summary>
        /// <returns>A list of instances for the drinks.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                list.Add(new AretinoAppleJuice() { Size = size });
                list.Add(new CandlehearthCoffee() { Size = size });
                list.Add(new MarkarthMilk() { Size = size });
                list.Add(new SailorSoda() { Size = size });
                list.Add(new WarriorWater() { Size = size });
            }
            return list;
        }

        /// <summary>
        /// Static method for the all menu items.
        /// </summary>
        /// <returns>A list of instances for all menu items.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Drinks());
            list.AddRange(Entrees());
            list.AddRange(Sides());
            return list;
        }
    }
}
