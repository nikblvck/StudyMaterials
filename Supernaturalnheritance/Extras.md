
Well done! You’ve created four new classes. Three of them are in an inheritance hierarchy: Archmage inherits from Mage, which inherits from Pupil. Each class has at least one method that uses the fourth class, Storm.

If you’d like more practice, try these optional challenges:

1. In Program.cs, store the Storm objects in an array instead of separate variables.
2.         Add a string Origin property and a new constructor to the Pupil class. The constructor should have two parameters, one for Title and one for Origin. Add a similar constructor to Mage and Archmage. In other words, you should be able to run this code in Program.cs:
Pupil p = new Pupil("Mezil-kree", "Icecrown");
Mage m = new Mage("Gul'dan", "Draenor");
Archmage a = new Archmage("Nielas Aran", "Stormwind");
3. Define an abstract class Spell with Essence, IsStrong, and Caster properties and an abstract Announce() method. Make Storm inherit from Spell. A Spell.cs file is included in the workspace — find it by clicking the folder icon at the top of the text editor.
