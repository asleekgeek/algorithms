/*
*
* Implementation of a queue data structure in C
* 
* 
*/

#include <stdio.h>
#include <stdlib.h>

typedef struct queue_node {
	void *data;
	struct queue_node *next;
} QueueNode;

QueueNode *first = NULL;
QueueNode *last = NULL;

QueueNode *new_queue_node(void *data) {
	
	QueueNode *new_node = (QueueNode*) malloc(sizeof(QueueNode));

	if (new_node == NULL) {
		return NULL;
	}

	new_node -> data = data;
	new_node -> next = NULL;

	return new_node;
}

int enqueue(void *data) {
	
	QueueNode *new_node = new_queue_node(data);

	if (new_node == NULL) {
		return 0;
	}

	if(first == NULL && last == NULL) {
		first = last = new_node;
		return 1;
	}

	last -> next = new_node;
    	last = new_node;
	return 1;
}

void *dequeue() {
	
	if (first == NULL) {
		return NULL;
	}

	QueueNode *temp = first;
	first = first -> next;
	temp -> next = NULL;
	void *data = temp -> data;
	free(temp);

	return data;
}

void *peek() {
   return first->data;
}

int main() {
	
	int a = 1;
	float b = 2.3;
	char c[] = "Hi from the queue!";

	// push
	enqueue((void*) (&a));
	enqueue((void*) (&b));
	enqueue((void*) (c));

	printf("Element at start of the queue: %d\n", *(int*)peek());
	
	// pop
	printf("Elements: \n");

    	int a_queued = *((int*) dequeue());
	printf("%d\n", a_queued);

	float b_queued = *((float*) dequeue());
	printf("%f\n", b_queued);

    	char *c_queued = (char*) dequeue();
	printf("%s\n", c_queued);

	if (dequeue() == NULL) {
		printf("Unable to dequeue from empty queue\n");
	}

	return 0;
}
