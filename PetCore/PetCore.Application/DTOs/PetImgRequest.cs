using System.ComponentModel.DataAnnotations;
using PetCore.Domain.Entities;

namespace PetCore.Application.DTOs;

public class PetImgRequest
{
    [Required(ErrorMessage = "O campo 'UrlImg' deve ser preenchido")]
    public string UrlImg { get; set; }
    
    public PetImgRequest(Pet pet)
    {
        UrlImg = pet.UrlImg;
    }
}