# Solar-Panel-Puzzle
The resolution of the Solar Panel Puzzle involves strategically positioning solar panels to maximize energy absorption and optimize power output.

# Problem
The university has created a new research department that is playing around with different kinds of solar panel technology. 

While the university has a limited number of types of panels, they can produce an unlimited supply of any panel. Each solar panel has a length, width and an energy output per unit area, stored in objects of a SolarPanel class:

public class SolarPanel
{  // assume length and width are in meters, and output is per square meter         public SolarPanel(int length, int width, int outputPerUnitArea)         {             Length = length;             Width = width;             OutputPerUnitArea = outputPerUnitArea;         }          public int Length { get; set; }         public int Width { get; set; }         public int OutputPerUnitArea { get; set; }     }


For example: 
// has a length of 4 meters, a width of 1 meter      // and an energy output of 33 units per square meter     var panel = new SolarPanel(4, 1, 33);

The university has also brought a farm of a limited area, and they want to maximize the energy that can be generated on the per unit area of land purchased. Write a method MaxOutput() that takes an array of solar panel objects and the land area (in square meters), and returns the maximum energy output per square meter that the farm can produce for the area of land.  

For example:

SolarPanel[] panels = new []     {         new SolarPanel(3, 3, 10),         new SolarPanel(2, 7, 12),         new SolarPanel(3, 4, 14),     };      var landArea = 81; // 81 square meters      // returns a total energy output of 1098      // where 1 of the first panel and 6 of the third panel were used     MaxOutput(panels, landArea); 
