using System;

namespace DrawShapes
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // SHAPE A (10 stars in a single row)
            //
            // **********
            //
            for (int i = 0; i < 10; i++)
            {
                DrawingTool.DrawOneStar();
            }
            DrawingTool.StartNewLine();
            DrawingTool.StartNewLine();

            // SHAPE B (5 stars in a single row, separated by spaces)
            //
            // * * * * * 
            //
            for (int i = 0; i < 5; i++)
            {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneSpace();
            }
            DrawingTool.StartNewLine();
            DrawingTool.StartNewLine();

            // SHAPE C  (10 rows of 10 stars each)
            //
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            //
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    DrawingTool.DrawOneStar();
                }

                DrawingTool.StartNewLine();
            }
            DrawingTool.StartNewLine();

            // SHAPE D (a triangle, I guess...)
            //
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            //
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < (i + 1); j++)
                {
                    DrawingTool.DrawOneStar();
                }

                DrawingTool.StartNewLine();
            }
            DrawingTool.StartNewLine();

            // SHAPE E (X)
            //
            // *        *
            //  *      * 
            //   *    *   
            //    *  *    
            //     **     
            //     **     
            //    *  *    
            //   *    *   
            //  *      * 
            // *        *
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i == j) || ((i+j) == 9))
                    {
                        DrawingTool.DrawOneStar();
                    }
                    else
                    {
                        DrawingTool.DrawOneSpace();
                    }
                }

                DrawingTool.StartNewLine();
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}