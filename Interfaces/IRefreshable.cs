﻿namespace WrapBlox.Interfaces;

public interface IRefreshable
{
    public DateTime RefreshedAt { get; set; }
    
    public Task RefreshAsync();
}