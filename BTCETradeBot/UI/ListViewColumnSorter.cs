// copyright (c) 2014 Sayyid Mohammad Saleh Samimi
// Donate: 1NBakuExebh2M9atfS3QuSmRPPtYU398VN
// 
// this file is part of BTCETradeBot.
// 
// BTCETradeBot is free software: you can redistribute it and/or modify
// it under the terms of the gnu general public license as published by
// the free software foundation, either version 3 of the license, or
// (at your option) any later version.
// 
// BTCETradeBot is distributed in the hope that it will be useful,
// but without any warranty; without even the implied warranty of
// merchantability or fitness for a particular purpose.  see the
// gnu general public license for more details.
// 
// you should have received a copy of the gnu general public license
// along with BTCETradeBot.  if not, see <http://www.gnu.org/licenses/>.

#region

using System;
using System.Collections;
using System.Windows.Forms;

#endregion

public class ListViewColumnSorter : IComparer
{
    private readonly CaseInsensitiveComparer ObjectCompare;

    private int ColumnToSort;

    private SortOrder OrderOfSort;

    public ListViewColumnSorter()
    {
        // Initialize the column to '0'
        ColumnToSort = 0;

        // Initialize the sort order to 'none'
        OrderOfSort = SortOrder.None;

        // Initialize the CaseInsensitiveComparer object
        ObjectCompare = new CaseInsensitiveComparer();
    }

    public int SortColumn
    {
        set { ColumnToSort = value; }
        get { return ColumnToSort; }
    }

    public SortOrder Order
    {
        set { OrderOfSort = value; }
        get { return OrderOfSort; }
    }

    #region IComparer Members

    public int Compare(object x, object y)
    {
        try
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem) x;
            listviewY = (ListViewItem) y;

            // Compare the two items
            long v1, v2;
            if (long.TryParse(listviewX.SubItems[ColumnToSort].Text, out v1) &&
                long.TryParse(listviewY.SubItems[ColumnToSort].Text, out v2))
            {
                compareResult = ObjectCompare.Compare(v1, v2);
            }
            else
            {
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text,
                                                      listviewY.SubItems[ColumnToSort].Text);
            }

            // Calculate correct return value based on object comparison
            if (OrderOfSort == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return (-compareResult);
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }
        catch (Exception)
        {
            return 0;
        }
    }

    #endregion
}