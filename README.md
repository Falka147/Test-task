# Test task

This project allows you to calculate the area of a triangle along three sides, or a circle along a radius.

To calculate the area of a figure, you need to call the static class Figure, and select the Square method.

Example: 

var squareOfFigure = Figure.Square(5) - in case of circle
  
var squareOfFigure = Figure.Square(2,5,3) - in case of triangle
  
According to the number of arguments passed as parameters, the area will be calculated. 1 argument - passed radius to calculate the area of the circle. 3 arguments - 3 sides of a triangle.

To add a new figure for calculation, you need to overload the Square method in the Figure class and add a class with the figure you need, following the example of circle and triangle figures.
The class of a new geometric figure must be inherited from the interface "Geometric figure".


(This variant of solving the test task has the initial simplest form)

Note: the completed second task is in the SECOND TASK file at the root 
