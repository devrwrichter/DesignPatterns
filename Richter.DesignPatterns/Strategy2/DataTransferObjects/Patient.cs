﻿namespace Richter.DesignPatterns.Strategy2.DataTransferObjects
{
    public record Patient
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
