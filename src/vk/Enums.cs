namespace Vulkan
{
    public enum VkInstanceCreateFlagBits: uint {
        /// <summary>
        /// Provided by VK_KHR_portability_enumeration. Specifies that the instance will enumerate
        /// available Vulkan Portability-compliant physical devices and groups in addition to the
        /// Vulkan physical devices and groups that are enumerated by default.
        /// </summary>
        PortabilityBitKHR = 1,
    };

    public static partial class RawConstants
    {
        public const VkInstanceCreateFlagBits VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR = VkInstanceCreateFlagBits.PortabilityBitKHR;
    };
}
