
using System;
using NUnit.Framework;
using SaddleDemo;

[TestFixture]
public class SaddlePointFinderTest
{
    [Test]
    public void GetSaddlePointsReturnNoSaddlePointsWhenThereIsNone()
    {
        SaddlePointFinder s = new SaddlePointFinder();
        int[,] mx = new int[5, 5] {
            { 0,1,0,1,0 },
            { 1,0,1,0,1 },
            { 0,1,0,1,0 },
            { 1,0,1,0,1 },
            { 0,1,0,1,0 },
        };
        string result = s.GetSaddlePoints(mx);
        Assert.AreEqual("No saddle points found.", result);
    }

    [Test]
    public void GetSaddlePointsReturns00When00IsSP()
    {
        SaddlePointFinder s = new SaddlePointFinder();
        int[,] mx = new int[5, 5] {
            { 2,1,0,1,0 },
            { 3,0,1,0,1 },
            { 3,1,0,1,0 },
            { 3,0,1,0,1 },
            { 3,1,0,1,0 },
        };
        string result = s.GetSaddlePoints(mx);
        Assert.AreEqual("0,0", result);
    }

    [Test]
    public void GetSaddlePointsReturns0001When0001AreSP()
    {
        SaddlePointFinder s = new SaddlePointFinder();
        int[,] mx = new int[5, 5] {
            { 2,2,0,1,0 },
            { 3,3,1,0,1 },
            { 3,3,0,1,0 },
            { 3,3,1,0,1 },
            { 3,3,0,1,0 },
        };
        string result = s.GetSaddlePoints(mx);
        Assert.AreEqual("0,0" + Environment.NewLine + "0,1", result);
    }

    [Test]
    public void GetSaddlePointsReturns00011011When00011011AreSP()
    {
        SaddlePointFinder s = new SaddlePointFinder();
        int[,] mx = new int[5, 5] {
            { 3,3,0,1,0 },
            { 3,3,1,0,1 },
            { 9,8,0,1,0 },
            { 9,8,1,0,1 },
            { 9,8,0,1,0 },
        };
        string result = s.GetSaddlePoints(mx);
        Assert.AreEqual("0,0" + Environment.NewLine + "0,1" + Environment.NewLine + "1,0" + Environment.NewLine + "1,1", result);
    }


    [Test]
    public void GetSaddlePointsReturns6SPs()
    {
        SaddlePointFinder s = new SaddlePointFinder();
        int[,] mx = new int[5, 5] {
            { 3,3,3,1,0 },
            { 3,3,3,0,1 },
            { 9,8,7,1,0 },
            { 9,8,7,0,1 },
            { 9,8,7,1,0 },
        };
        string result = s.GetSaddlePoints(mx);
        Assert.AreEqual("0,0" + Environment.NewLine + "0,1" + Environment.NewLine + "0,2" 
            + Environment.NewLine + "1,0" + Environment.NewLine + "1,1" + Environment.NewLine + "1,2", result);
    }

}