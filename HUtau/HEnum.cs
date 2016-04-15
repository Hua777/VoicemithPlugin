namespace HUtau
{
    public enum NoteTypeInTmpFile
    {
        Original, Insert, Delete, Prev, Next
    }

    public enum PPFixName
    {
        XYYV3OutsideUniqueStrongVowel,
        XYYV3OutsideUniqueObscureSound,
        XYYV3OutsideUniqueFullSound,
        XYYV3InsidePeaceStrongVowel,
        XYYV3InsidePeaceObscureSound,
        XYYV3InsidePeaceFullSound,
        XYYV3InsideCantoStrongVowel,
        XYYV3InsideCantoObscureSound,
        XYYV3InsideCantoFullSound,
        XYYV3OtherMuffle,
        XYYV3OtherSpecialDearStrongVowel,
        XYYV3OtherSpecialDearFullSound,
        NULL
    }

    public enum ScrollDirect
    {
        Left, Right, Top, Bottom
    }

    public enum Smaller
    {
        X, Y
    }

    public enum MouseOn
    {
        SelectedNotes,
        UnSelectedNotes,
        Space
    }

    public enum NotesSelection
    {
        Changed, UnChange
    }

    public enum MouseCursor
    {
        Arrow, Pen
    }
}
