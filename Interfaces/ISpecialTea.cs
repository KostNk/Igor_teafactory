using System;

namespace task5.Interfaces;

/// <summary>
/// Интерфейс для специальных чаев с уникальным эффектом
/// </summary>
public interface ISpecialTea : IBeverageBase
{
    string GetSpecialEffect();
    string GetSpecialId();
}

