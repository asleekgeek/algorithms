#include <stdio.h>

#define MAXSIZE 64     
int stack[MAXSIZE];     
int top = -1;            

int peek() 
{
   return stack[top];
}

int pop() 
{
   int data;
	
   if(top != -1) 
   {
      data = stack[top--];
      return data;
   } else {
      printf("Could not retrieve data, Stack is empty.\n");
   }

   return -1;
}

void push(int data) 
{
   if(top != MAXSIZE) 
   {
      stack[++top] = data;
   } else {
      printf("Could not insert data, Stack is full.\n");
   }
}

int main() 
{
   // push
   push(3);
   push(5);
   push(9);
   push(1);
   push(12);
   push(15);

   printf("Element at top of the stack: %d\n" ,peek());
   printf("Elements: \n");

   // pop 
   while(top != -1) {
      int data = pop();
      printf("%d\n",data);
   }

   return 0;
}