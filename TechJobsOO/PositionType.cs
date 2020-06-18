﻿using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType position &&
                   Id == position.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}
