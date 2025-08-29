// Strategy Pattern

// The strategy Pattern is used to pass different algorithms , or behaviours, to an object.

// First, let's consider an application tha store videos. Before storing a video, the video needs to
// be compresses using a specific compression algorithm, such as MOV or MP4, then, if necessary,
// apply an overlay to the video, such as black and or blur.

using Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.Strategy.GoodExample;

var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
videoStorage.Store("/videos/some-movie");

videoStorage.SetCompressor(new CompressorMP4());
videoStorage.SetOverlay(new OverlayNone());
videoStorage.Store("/videos/some-movie");


// Diference between Strategy and State
// The two patterns are similar in pratice, and the diference between them varies depending on who you ask, Some popular choices are:

// - States store a referenceto the context object the contains them. Strategies do not.
// - States are allowed to repalce themselves (IE: to change the satte of the context objects to something else), while Strategies are not.
// - Strategies only handle a single , specific task , while States provide the underlying implementation for everything ( or most everything) the context object does.