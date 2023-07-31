﻿#region Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
#endregion
// Francis Sullivan 30034007
// AT1 2023.07.17
namespace Malin_Space_Science_Systems_Satellite_Data_Processor
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Initialisation
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion
        #region Global Methods (4.1 to 4.4)
        #region 4.1 Linked Lists
        /*
        Create two data structures using the LinkedList<T> class from the C# Systems.Collections.Generic
        namespace. The data must be of type “double”; you are not permitted to use any additional classes,
        nodes, pointers or data structures (array, list, etc) in the implementation of this application. 
        The two LinkedLists of type double are to be declared as global within the “public partial class”.
        */
        #endregion
        #region 4.2 Load Data from DLL into Linked Lists
        /*
        Copy the Galileo.DLL file into the root directory of your solution folder and add the appropriate
        reference in the solution explorer. Create a method called “LoadData” which will populate both
        LinkedLists. Declare an instance of the Galileo library in the method and create the appropriate loop
        construct to populate the two LinkedList; the data from Sensor A will populate the first LinkedList,
        while the data from Sensor B will populate the second LinkedList. The LinkedList size will be
        hardcoded inside the method and must be equal to 400. The input parameters are empty, and the
        return type is void.
        */
        #endregion
        #region 4.3 Display Linked Lists in List View
        /*
        Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a
        ListView. Add column titles “Sensor A” and “Sensor B” to the ListView. The input parameters are
        empty, and the return type is void.
        */
        #endregion
        #region 4.4 Call 4.2 & 4.3
        /*
        Create a button and associated click method that will call the LoadData and ShowAllSensorData methods. 
        The input parameters are empty, and the return type is void.
        */
        #endregion
        #endregion
        #region Utility Methods (4.5 to 4.6)
        #region 4.5 Count Linked List Elements
        /*
        Create a method called “NumberOfNodes” that will return an integer which is the number of
        nodes(elements) in a LinkedList. The method signature will have an input parameter of type
        LinkedList, and the calling code argument is the linkedlist name.
        */
        #endregion
        #region 4.6 Display Linked Lists in List Boxes
        /*
        Create a method called “DisplayListboxData” that will display the content of a LinkedList inside the
        appropriate ListBox. The method signature will have two input parameters; a LinkedList, and the
        ListBox name. The calling code argument is the linkedlist name and the listbox name.
        */
        #endregion
        #endregion
        #region Sort and Search Methods (4.7 to 4.10)
        #region 4.7 Sort: Selection
        /*
        Create a method called “SelectionSort” which has a single input parameter of type LinkedList, while
        the calling code argument is the linkedlist name. The method code must follow the pseudo code
        supplied below in the Appendix. The return type is Boolean.
        */
        #endregion
        #region 4.8 Sort: Insertion
        /*
        Create a method called “InsertionSort” which has a single parameter of type LinkedList, while the
        calling code argument is the linkedlist name. The method code must follow the pseudo code supplied
        below in the Appendix. The return type is Boolean.
        */
        #endregion
        #region 4.9 Search: Iterative
        /*
        Create a method called “BinarySearchIterative” which has the following four parameters: LinkedList,
        SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element
        from a successful search or the nearest neighbour value. The calling code argument is the linkedlist
        name, search value, minimum list size and the number of nodes in the list. The method code must
        follow the pseudo code supplied below in the Appendix.
        */
        #endregion
        #region 4.10 Search: Recursive
        /*
        Create a method called “BinarySearchRecursive” which has the following four parameters: LinkedList,
        SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element
        from a successful search or the nearest neighbour value. The calling code argument is the linkedlist
        name, search value, minimum list size and the number of nodes in the list. The method code must
        follow the pseudo code supplied below in the Appendix.
        */
        #endregion
        #endregion
        #region UI Button Methods (4.11 to 4.15)
        #region 4.11 Buttons: Search
        /*
        Create four button click methods that will search the LinkedList for an integer value entered into a
        textbox on the form. The four methods are:
            1. Method for Sensor A and Binary Search Iterative
            2. Method for Sensor A and Binary Search Recursive
            3. Method for Sensor B and Binary Search Iterative
            4. Method for Sensor B and Binary Search Recursive
        The search code must check to ensure the data is sorted, then start a stopwatch before calling the
        search method. Once the search is complete the stopwatch will stop, and the number of ticks will be
        displayed in a read only textbox. Finally, the code/method will call the “DisplayListboxData” method
        and highlight the search target number and two values on each side
        */
        #endregion
        #region 4.12 Buttons: Sort
        /*
        Create four button click methods that will sort the LinkedList using the Selection and Insertion
        methods. The four methods are:
            1. Method for Sensor A and Selection Sort
            2. Method for Sensor A and Insertion Sort
            3. Method for Sensor B and Selection Sort
            4. Method for Sensor B and Insertion Sort
        The button method must start a stopwatch before calling the sort method. Once the sort is complete
        the stopwatch will stop, and the number of milliseconds will be displayed in a read only textbox.
        Finally, the code/method will call the “ShowAllSensorData” method and “DisplayListboxData” for the
        appropriate sensor.
        */
        #endregion
        #region 4.13 Combo Boxes: Sigma and Mu
        /*
        Add two numeric input controls for Sigma and Mu. The value for Sigma must be limited with a
        minimum of 10 and a maximum of 20. Set the default value to 10. The value for Mu must be limited
        with a minimum of 35 and a maximum of 75. Set the default value to 50.
        */
        #endregion
        #region 4.14 Text Boxes: Interger Input for Search
        /*
        Add two textboxes for the search value; one for each sensor, ensure only numeric integer values can
        be entered.
        */
        #endregion
        #endregion
    }
}
