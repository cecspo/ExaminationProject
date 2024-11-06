﻿namespace CustomerProvider.Interfaces;

public interface IFileService
{
    public bool SaveToFile(string filePath, string content);

    public string GetFromFile(string filePath);
}
