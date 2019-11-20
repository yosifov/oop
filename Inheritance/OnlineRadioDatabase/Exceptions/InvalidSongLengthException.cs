﻿namespace OOP.Inheritance.OnlineRadioDatabase.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public override string Message => "Invalid song length.";
    }
}
