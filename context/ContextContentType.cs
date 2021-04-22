namespace Health.Direct.Context
{
    /// <summary>
    /// Represents a <c>ihe-format-code</c>. 
    /// </summary>
    /// <remarks>
    /// This is an extension property to the direct context 1.1 IG as described in the Event Notifications via hte Direct Standard IG
    /// See <a href="https://directtrust.app.box.com/s/g7dmzskfmuczle0gzn9kk9gp0cfhjwhb">Event Notifitions via the Direct Standard</a>.
    ///
    /// content-type-element = “content-type:” code “/” display “/” code-system “/” code-system-name
    ///
    /// code = codes from valueSet ADT Event Notification Types (oid to be established in VSAC)
    /// display = LOINC LongName of associated LOINC code
    /// code-system = urn:oid:2.16.840.1.113883.6.1
    /// code-system-name = LOINC
    public class ContextContentType
    {
        public string Code { get; set; }

        public string Display { get; set; }

        public string CodeSystem { get; set; }

        public string CodeSystemName { get; set; }

        /// <summary>
        /// Format <c>content-type value as code/display/code-system/code-system-name</c>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Code}/{Display}/{CodeSystem}/{CodeSystemName}";
        }
    }
}
