﻿using AdventOfCode2022.Puzzles.Day01CalorieCounting;
using AdventOfCode2022.Puzzles.Day02RockPaperScissors;
using AdventOfCode2022.Puzzles.Day03RucksackReorganization;
using AdventOfCode2022.Puzzles.Day04CampCleanup;
using AdventOfCode2022.Puzzles.Day05SupplyStacks;
using AdventOfCode2022.Puzzles.Day06TuningTrouble;

Dictionary<int, IAdventPuzzle> directory = new Dictionary<int, IAdventPuzzle>
{
    { 1, new CalorieCounting() },
    { 2, new CalorieCounting2() },
    { 3, new RockPaperScissors() },
    { 4, new RockPaperScissors2() },
    { 5, new RucksackReorganization() },
    { 6, new RucksackReorganization2() },
    { 7, new CampCleanup() },
    { 8, new CampCleanup2() },
    { 9, new SupplyStacks() },
    { 10, new SupplyStacks2() },
    { 11, new TuningTrouble() },
    { 12, new TuningTrouble2() },
};

Console.WriteLine("Select a puzzle to run:");

foreach (var puzzle in directory)
{
    Console.WriteLine($"{puzzle.Key}: {puzzle.Value.GetName()}");
}
var index = Convert.ToInt32(Console.ReadLine());
directory[index].Run();
Console.ReadLine();
