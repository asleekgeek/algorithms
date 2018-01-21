#include <stdio.h>

#define MAXSIZE 64 
int queue[MAXSIZE];
int first = 0;
int last = 0;

int peek() 
{
    return queue[first];
}

int dequeue() 
{
    int data;

    if(first != last) 
    {
        data = queue[first++];
        return data;
    } else {
        printf("Could not retrieve data, queue is empty.\n");
    }

    return -1;
}

void enqueue(int data)
{
    if(last != MAXSIZE - 1) 
    {
        queue[last++] = data;
    } else {
        printf("Could not insert data, queue is full.\n");
    }
}

int main() 
{    
    // push
    enqueue(3);
    enqueue(5);
    enqueue(9);
    enqueue(1);
    enqueue(12);
    enqueue(15);

    printf("First element of the queue: %d\n", peek());
    printf("Elements: \n");

    // dequeue 
    while(first != last) {
        int data = dequeue();
        printf("%d\n",data);
    }

    return 0;
}