﻿namespace FastEndpoints;

/// <summary>
/// boolean properties decorated with this attribute will have their values set to true if the current principal has the specified permission.
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class HasPermissionAttribute : Attribute
{
    /// <summary>
    /// the permission to check for
    /// </summary>
    public string Permission { get; set; }

    /// <summary>
    /// set to true if a validation error should be thrown when the current user principal doesn't have the specified permission
    /// </summary>
    public bool IsRequired { get; set; }

    /// <summary>
    /// boolean properties decorated with this attribute will have their values set to true if the current principal has the specified permission.
    /// </summary>
    /// <param name="permission">the permission to check for</param>
    /// <param name="isRequired">set to false if a validation error shouldn't be thrown when the current principal doesn't have the specified permission.</param>
    public HasPermissionAttribute(string permission, bool isRequired = true)
    {
        Permission = permission;
        IsRequired = isRequired;
    }
}
