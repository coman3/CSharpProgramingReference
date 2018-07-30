//For that beautiful Ctrl+F:  START HERE / BEGIN HERE / READ FROM HERE / INTRODUCTION

#region |=======================INFORMATION=========================|
/* 
 *                              BASIC CLASS
 *   
 *      This document contains a very basic C# class structure.
 *      If you are just starting with this solution, i would highly
 *      recommended you start here, and move on to other files within 
 *      the General Project for more examples.
 *  
 * 
 */

#region |=========================LICENCE===========================|
/* 
*       Document Created By: 
*       Lachlan van der Velden 
*       (mailto:me@lachlanvelden.com) (https://lachlanvelden.com)
*       
*       Do not distribute any source from this solution, in its entirety
*       or separated without explicit permission from the document creator.  
*       permission is granted by a friendly email request.
* 
*       Thank you for your understanding. 
*/
#endregion


using System;

namespace OOP.Summary.General
{

    /// <summary>
    /// A General Game class that contains basic information about a game, and when it was released.
    /// </summary>
    public class Game
    {

        #region Variables
        /// <summary>
        /// The name of the game.
        /// </summary>
        public string Name { get; set; }
        // Name is an 'auto' Property. Properties will automatically generate a private field, with both `{FieldType} Get{FieldName}` and `void Set{FieldName}({Type} value)`
        // These are very useful, as we can specify if we want to allow public setting or getting.
        // More Information on properties in the Properties Project


        /// <summary>
        /// The date and time this game was released on.
        /// </summary>
        public DateTime ReleaseDate;

        // ReleaseDate is a field. Fields are the more basic way of object storage (variables)
        // These are mostly used if you do not need to specify if you can access setting or getting.
        // Again more information on these, and how it is recommended to use them, can be found in the Fields Project.


        #endregion


        #region Procedures & Functions
        /// <summary>
        /// Set the games description.
        /// 
        /// <remarks>
        /// Supports Multi line markdown formating in description field
        /// </remarks>
        /// </summary>
        /// <param name="description"></param>
        public void SetDescription(string description)
        {
            // Pretend we are doing some fancy thingy to description here... (im too lazy to write fake code tbh)
            this.Description = description;
        }
        // SetDescription is a Method. Methods execute a returnless set of instructions.
        // As all of these lil' comments, check out the Methods Project for more info. (i also added some example code there for a clearer understanding)


        /// <summary>
        /// Gets the games description.
        /// 
        /// <remarks>
        /// Supports Multi line markdown formating
        /// </remarks>
        /// </summary>
        /// <param name="description"></param>
        public string GetDescription()
        {
            return this.Description;
        }
        // GetDescription is a Function. Functions execute a returnful set of instructions.
        // Yep, go check out the Functions Project for more info. (i again also added some example code there for a clearer understanding)



        #endregion























































        #region Demonstraton Variables
        // You are a curious little developer aint you? Nice work!
        // Just because you had a lookie here, heres some usefull links:
        // Microsoft Docs (goes into alot of depth): https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/
        // A nice little quick reference sheet, only if you dont like this project ofcause ;) : https://www.tutorialspoint.com/csharp/csharp_quick_guide.htm
        // if you want a printable cheat sheet: https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf (save the trees please!)
        // 



        private string Description;

        #endregion
    }
}
