using System.ComponentModel.DataAnnotations;
using Charwiki.ClassLib.Models;

namespace Charwiki.ClassLib.Dto.Request;

/// <summary>
/// Represents a Loomian set in the game.
/// </summary>
public class SubmitLoomianSetRequestDto
{
    /// <summary>
    /// The unique identifier of the Loomian the set is for.
    /// </summary>
    [Required(ErrorMessage = "Loomian is required.")]
    public Guid? LoomianId { get; set; }

    /// <summary>
    /// The personality modifiers of the Loomian in the set.
    /// </summary>
    public StatsSet? PersonalityModifiers { get; set; }

    /// <summary>
    /// The unique identifier of the ability of the Loomian in the set.
    /// </summary>
    [Required(ErrorMessage = "Ability is required.")]
    public Guid? AbilityId { get; set; }

    /// <summary>
    /// The unique identifier of the item the Loomian is holding.
    /// </summary>
    public Guid? ItemId { get; set; }

    /// <summary>
    /// The training points of the Loomian.
    /// </summary>
    public StatsSet? TrainingPoints { get; set; }

    /// <summary>
    /// The unique points of the Loomian.
    /// </summary>
    public StatsSet? UniquePoints { get; set; }

    #region Moveset
    /// <summary>
    /// The unique identifier of the first move of the Loomian.
    /// </summary>
    public Guid? Move1Id { get; set; }

    /// <summary>
    /// The unique identifier of the second move of the Loomian.
    /// </summary>
    public Guid? Move2Id { get; set; }

    /// <summary>
    /// The unique identifier of the third move of the Loomian.
    /// </summary>
    public Guid? Move3Id { get; set; }

    /// <summary>
    /// The unique identifier of the fourth move of the Loomian.
    /// </summary>
    public Guid? Move4Id { get; set; }
    #endregion

    #region Descriptive Fields
    /// <summary>
    /// The title of the set.
    /// </summary>
    [Required(ErrorMessage = "Title is required.")]
    [StringLength(15, ErrorMessage = "Title cannot exceed 15 characters.")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// A short description of the set.
    /// </summary>
    [Required(ErrorMessage = "Short description is required.")]
    [StringLength(50, ErrorMessage = "Short description cannot exceed 50 characters.")]
    public string ShortDescription { get; set; } = string.Empty;

    /// <summary>
    /// The explanation of the set.
    /// </summary>
    [StringLength(500, ErrorMessage = "Explanation cannot exceed 500 characters.")]
    public string? Explanation { get; set; }

    /// <summary>
    /// The strategy of the set.
    /// </summary>
    [StringLength(500, ErrorMessage = "Strategy cannot exceed 500 characters.")]
    public string? Strategy { get; set; }

    /// <summary>
    /// The strengths of the set.
    /// </summary>
    public List<string>? Strengths { get; set; }

    /// <summary>
    /// The weaknesses of the set.
    /// </summary>
    public List<string>? Weaknesses { get; set; }

    /// <summary>
    /// The other options of the set.
    /// </summary>
    [StringLength(500, ErrorMessage = "Other options cannot exceed 500 characters.")]
    public string? OtherOptions { get; set; }
    #endregion

    #region Game Info
    /// <summary>
    /// The unique identifier of the game version info of the set.
    /// </summary>
    [Required(ErrorMessage = "Game version is required.")]
    public Guid? GameVersionInfoId { get; set; }
    #endregion

    #region Conversion Methods
    /// <summary>
    /// Converts the DTO to a Loomian set object.
    /// </summary>
    /// <param name="creatorId">The value that will be set to the LoomianSet's CreatorId</param>
    /// <returns></returns>
    public LoomianSet ToLoomianSet(Guid creatorId)
    {
        return new LoomianSet
        {
            LoomianId = LoomianId ?? Guid.Empty,
            PersonalityModifiers = PersonalityModifiers,
            LoomianAbilityId = AbilityId ?? Guid.Empty,
            ItemId = ItemId,
            TrainingPoints = TrainingPoints,
            UniquePoints = UniquePoints,
            Move1Id = Move1Id,
            Move2Id = Move2Id,
            Move3Id = Move3Id,
            Move4Id = Move4Id,
            Title = Title,
            ShortDescription = ShortDescription,
            Explanation = Explanation,
            Strategy = Strategy,
            Strengths = Strengths,
            Weaknesses = Weaknesses,
            OtherOptions = OtherOptions,
            GameVersionInfoId = GameVersionInfoId ?? Guid.Empty,
            CreatorId = creatorId
        };
    }
    #endregion
}