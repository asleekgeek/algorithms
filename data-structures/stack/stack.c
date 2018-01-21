#include <stdio.h>
#include <stdlib.h>

typedef struct stack_node {
	void *data;
	struct stack_node *next;
} StackNode;

StackNode *top = NULL;

StackNode* new_stack_node(void *data) 
{
	StackNode *new_node = (StackNode*) malloc(sizeof(StackNode));

	if (new_node == NULL) 
	{
		return NULL;
	}

	new_node -> data = data;
	new_node -> next = NULL;

	return new_node;
}

int push(void *data) 
{
	StackNode *new_node = new_stack_node(data);

	if (new_node == NULL) 
	{
		return 0;
	}

	new_node -> next = top;
	top = new_node;
	
	return 1;
}

void* pop() 
{
	if (top == NULL) 
	{
		return NULL;
	}

	StackNode *temp = top;
	top = top -> next;
	temp -> next = NULL;
	void *data = temp -> data;
	free(temp);

	return data;
}

void *peek() 
{
   return top->data;
}

int main() 
{
	int a = 1;
	float b = 2.3;
	char c[] = "Hi from the stack!";

	// push
	push((void*) (&a));
	push((void*) (&b));
	push((void*) (c));

	printf("Element at top of the stack: %s\n", (char*)peek());
	
	// pop
	printf("Elements: \n");

	char *c_popped = (char*) pop();
	printf("%s\n", c_popped);

	float b_popped = *((float*) pop());
	printf("%f\n", b_popped);
	
	int a_popped = *((int*) pop());
	printf("%d\n", a_popped);

	if (pop() == NULL) 
	{
		printf("Unable to pop from empty stack\n");
	}

	return 0;
}
