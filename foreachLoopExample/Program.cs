﻿string[] inventory = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
int bin = 0;

foreach(string item in inventory) {
    if(item.StartsWith("B")) {
        Console.WriteLine($"{item} starts with B");
    }
}
