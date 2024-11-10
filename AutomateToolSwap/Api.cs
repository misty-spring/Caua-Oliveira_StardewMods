// ReSharper disable UnusedMember.Global

namespace AutomateToolSwap;

public interface IItemExtensionsApi
{
    /// <summary>
    /// Checks for resource data in the mod.
    /// </summary>
    /// <param name="id">Qualified item ID</param>
    /// <param name="health">MinutesUntilReady value</param>
    /// <param name="itemDropped">Item dropped by ore</param>
    /// <returns>Whether the object has resource data.</returns>
    bool IsResource(string id, out int? health, out string itemDropped);

    /// <summary>
    /// Checks for a qualified id in modded clump data (vanilla not included).
    /// </summary>
    /// <param name="qualifiedItemId">Qualified item ID.</param>
    /// <returns>Whether this id is a clump's.</returns>
    bool IsClump(string qualifiedItemId);
    
    bool GetResourceData(string id, bool isClump, out object data);
    bool GetBreakingTool(string id, bool isClump, out string tool);
}
