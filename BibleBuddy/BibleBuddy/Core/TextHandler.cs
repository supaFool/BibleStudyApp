namespace BibleBuddy.Core
{
    using static BibleBuddy.Core.BibleVersions.KJV;
    internal class TextHandler
    {
        private BibleBuddyForm m_form;
        private string m_name;
        private string m_chapter;
        private string m_verse;
        private string m_verseText;

        public TextHandler(BibleBuddyForm form)
        {
               m_form = form;
        }

        private void GetBookName()
        {
        }

        private void SetText()
        {
            m_form.Kjv_Label_BookTitle.Text = m_name;
            m_form.Kjv_Label_Chapter.Text = m_chapter;
            m_form.Kjv_Label_VerseText.Text = m_verseText;
            m_form.BibleLayout.Refresh();
        }

    }
}
