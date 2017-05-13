using System;
using System.Collections.Generic;
using System.Linq;

namespace IngenioTest_Console
{
    public enum SortOrder
    {
        Ascending,
        Descending
    }

    public abstract class Chip
    {
        public string ChipName;
        public SortOrder SortType;

        protected Chip(string chipName)
        {
            this.ChipName = chipName;
        }
        protected Chip(string chipName, SortOrder sortType)
        {
            this.ChipName = chipName;
            this.SortType = sortType;
        }

        public abstract int[] ExecuteChip(int[] array);
    }

    public class SortofChips : Chip
    {
        public SortofChips(string chipName) : base(chipName)
        {
        }

        public override int[] ExecuteChip(int[] array)
        {
            if (base.SortType == SortOrder.Descending)
            {
                Array.Sort(array);
                Array.Reverse(array);
                return array;
            }
            else
            {
                Array.Sort(array);
                return array;
            }
        }
    }

    public class TotalofChips : Chip
    {

        public TotalofChips(string chipName) : base(chipName)
        {
        }

        public override int[] ExecuteChip(int[] array)
        {
            var newArray = new int[1];
            newArray[0] = array.Sum();
            return newArray;
        }
    }

    public class Robot
    {
        #region Singleton Robot Implementation
        private static Robot _robotInstance;

        public Robot(string name)
        {
            this.Name = name;
        }

        public static Robot Instance(string name)
        {
            return _robotInstance ?? (_robotInstance = new Robot(name));
        }
        #endregion Singleton Robot Implementation



        //Robot Name
        public string Name;
        //Chip Count
        public static uint ChipCount;
        //Unique Chip names
        public static List<String> ChipNames = new List<string>();
        //Pluggable Chip
        public Chip Chip;

        public int[] ExecuteChip(int[] array)
        {
            return this.Chip.ExecuteChip(array);
        }

        public void InstallChip(Chip iChip)
        {
            //assign chip
            this.Chip = iChip;

            //Increment chip count only if the chip is unique
            if (!ChipNames.Contains(iChip.ChipName))
            {
                ChipNames.Add(iChip.ChipName);
                ChipCount++;
            }

        }
    }
}