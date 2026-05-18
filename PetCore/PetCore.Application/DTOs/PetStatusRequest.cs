using System.ComponentModel.DataAnnotations;
using PetCore.Domain.Entities;

namespace PetCore.Application.DTOs;

public class PetStatusRequest
{
    [Required(ErrorMessage = "O campo 'Status' deve ser preenchido")]
    public bool? Status { get;  set; }

    public PetStatusRequest(Pet pet)
    {
        Status = pet.Status;
    }
}