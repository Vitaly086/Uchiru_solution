using System.ComponentModel.DataAnnotations;

namespace Task10.Models;

public class DepositModel
{
    [Required(ErrorMessage = "Поле Сумма вклада обязательно для заполнения.")]
    [Range(1, double.MaxValue, ErrorMessage = "Сумма вклада должна быть больше 1.")]
    public double InitialAmount { get; set; }

    [Required(ErrorMessage = "Поле Количество месяцев обязательно для заполнения.")]
    [Range(1, 60, ErrorMessage = "Количество месяцев должно быть в диапазоне от 1 до 60.")]
    public int NumberOfMonths { get; set; }
}