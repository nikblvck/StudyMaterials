// Pupil.cs
using System;

namespace MagicalInheritance
{
 class Pupil
  {
    public string Title
    { get; private set; }

    //Constructor
   public Pupil(string title)
   {
     Title = title;
   }

   //Method
   public Storm CastWindStorm()
   {
     return new Storm("wind", false, Title);
   }
  }
}
