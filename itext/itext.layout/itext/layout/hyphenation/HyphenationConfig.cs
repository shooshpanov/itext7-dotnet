/*

This file is part of the iText (R) project.
Copyright (c) 1998-2019 iText Group NV
Authors: Bruno Lowagie, Paulo Soares, et al.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;

namespace iText.Layout.Hyphenation {
    /// <summary>This is the class used to configure hyphenation on layout level</summary>
    public class HyphenationConfig {
        /// <summary>The Hyphenator object.</summary>
        protected internal Hyphenator hyphenator;

        /// <summary>The hyphenation symbol used when hyphenating.</summary>
        protected internal char hyphenSymbol = '-';

        /// <summary>
        /// Constructs a new
        /// <see cref="HyphenationConfig"/>
        /// . No language hyphenation files will be used.
        /// Only soft hyphen symbols ('\u00ad') will be taken into account.
        /// </summary>
        /// <param name="leftMin">the minimum number of characters before the hyphenation point</param>
        /// <param name="rightMin">the minimum number of characters after the hyphenation point</param>
        public HyphenationConfig(int leftMin, int rightMin) {
            this.hyphenator = new Hyphenator(null, null, leftMin, rightMin);
        }

        /// <summary>
        /// Constructs a new
        /// <see cref="HyphenationConfig"/>
        /// by a
        /// <see cref="Hyphenator"/>
        /// which will be used to
        /// find hyphenation points.
        /// </summary>
        /// <param name="hyphenator">
        /// the
        /// <see cref="Hyphenator"/>
        /// instance
        /// </param>
        public HyphenationConfig(Hyphenator hyphenator) {
            this.hyphenator = hyphenator;
        }

        /// <summary>
        /// Constructs a new
        /// <see cref="HyphenationConfig"/>
        /// instance.
        /// </summary>
        /// <param name="lang">the language</param>
        /// <param name="country">the optional country code (may be null or "none")</param>
        /// <param name="leftMin">the minimum number of characters before the hyphenation point</param>
        /// <param name="rightMin">the minimum number of characters after the hyphenation point</param>
        public HyphenationConfig(String lang, String country, int leftMin, int rightMin) {
            this.hyphenator = new Hyphenator(lang, country, leftMin, rightMin);
        }

        /// <summary>Hyphenates a given word.</summary>
        /// <returns>
        /// 
        /// <see cref="Hyphenation"/>
        /// object representing possible hyphenation points
        /// or
        /// <see langword="null"/>
        /// if no hyphenation points are found.
        /// </returns>
        /// <param name="word">Tee word to hyphenate</param>
        public virtual iText.Layout.Hyphenation.Hyphenation Hyphenate(String word) {
            return hyphenator != null ? hyphenator.Hyphenate(word) : null;
        }

        /// <summary>Gets the hyphenation symbol.</summary>
        /// <returns>the hyphenation symbol</returns>
        public virtual char GetHyphenSymbol() {
            return hyphenSymbol;
        }

        /// <summary>Sets the hyphenation symbol to the specified value.</summary>
        /// <param name="hyphenSymbol">the new hyphenation symbol</param>
        public virtual void SetHyphenSymbol(char hyphenSymbol) {
            this.hyphenSymbol = hyphenSymbol;
        }
    }
}
