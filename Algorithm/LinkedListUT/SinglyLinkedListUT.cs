using LinkedList.SinglyLinkedList;

namespace LinkedListUT;

public class SinglyLinkedListUT
{
    [Fact]
    public void IsEmpty_ShouldBeTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        Assert.True(list.IsEmpty);
    }

    [Fact]
    public void IsEmpty_ShouldBeFalse()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        Assert.False(list.IsEmpty);
    }

    [Fact]
    public void AddFirst_ShouldBeReturnTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);

        Assert.Equal(2, list.Head!.Value);
        Assert.Equal(1, list.Tail!.Value);
    }

    [Fact]
    public void AddLast_ShouldBeReturnTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);

        Assert.Equal(1, list.Head!.Value);
        Assert.Equal(2, list.Tail!.Value);
    }

    [Fact]
    public void RemoveFirst_ShouldBeReturnTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);

        Assert.Equal(3, list.RemoveFirst());
        Assert.Equal(2, list.Head!.Value);
    }

    [Fact]
    public void RemoveFirst_ShouldBeThrowException()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        Assert.Throws<Exception>(() => list.RemoveFirst());
    }

    [Fact]
    public void RemoveLast_ShouldBeReturnTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);

        Assert.Equal(1, list.RemoveLast());
        Assert.Equal(2, list.Tail!.Value);
    }

    [Fact]
    public void RemoveLast_ShouldBeThrowException()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        Assert.Throws<Exception>(() => list.RemoveLast());
    }

    [Fact]
    public void Clear_ShouldBeReturnTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);

        list.Clear();
        Assert.True(list.IsEmpty);
    }

    [Fact]
    public void Remove_ShouldBeReturnTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);

        list.Remove(2);
        list.Remove(4);

        Assert.Equal(3, list.Count);
        Assert.Equal(5, list.Head!.Value);
        Assert.Equal(1, list.Tail!.Value);
    }

    [Fact]
    public void RemoveAt_ShouldBeReturnTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);

        // 5 -> 4 -> 3 -> 2 -> 1
        // 5 -> 4 -> 2 -> 1
        // 5 -> 4 -> 2


        list.RemoveAt(2);
        list.RemoveAt(3);

        Assert.Equal(3, list.Count);
        Assert.Equal(5, list.Head!.Value);
        Assert.Equal(2, list.Tail!.Value);
    }

    [Fact]
    public void IndexOf_ShouldBeReturnIndex()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);

        Assert.Equal(0, list.IndexOf(5));
        Assert.Equal(2, list.IndexOf(3));
        Assert.Equal(4, list.IndexOf(1));
    }

    [Fact]
    public void IndexOf_ShouldBeReturnNegativeOne()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);

        Assert.Equal(-1, list.IndexOf(6));
        Assert.Equal(-1, list.IndexOf(0));
    }

    [Fact]
    public void Contains_ShouldBeReturnTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);

        Assert.True(list.Contains(5));
        Assert.True(list.Contains(3));
        Assert.True(list.Contains(1));
    }

    [Fact]
    public void Contains_ShouldBeReturnFalse()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);

        Assert.False(list.Contains(6));
        Assert.False(list.Contains(0));
    }

    [Fact]
    public void PeakFirst_ShouldBeReturnFirstValue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);

        Assert.Equal(5, list.PeakFirst());
    }

    [Fact]
    public void PeakFirst_ShouldBeThrowException()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        Assert.Throws<Exception>(() => list.PeakFirst());
    }

    [Fact]
    public void PeakLast_ShouldBeReturnLastValue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);

        Assert.Equal(1, list.PeakLast());
    }

    [Fact]
    public void PeakLast_ShouldBeThrowException()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        Assert.Throws<Exception>(() => list.PeakLast());
    }

    [Fact]
    public void Reverse_ShouldBeReturnTrue()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);
        list.AddFirst(5);

        list.Reverse();

        Assert.Equal(1, list.Head!.Value);
        Assert.Equal(5, list.Tail!.Value);
    }
}