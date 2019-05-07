﻿public class Segment
{
    public int instrument;
    public int sequence;

    public Segment(int _instrument, int _sequence)
    {
        instrument = _instrument;
        sequence = _sequence;
    }

    public bool PlayBeat(int beat) => (beat & sequence) != 0;
}