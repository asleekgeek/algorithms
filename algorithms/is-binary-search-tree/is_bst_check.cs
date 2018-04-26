/*
*
* 2018-03-22 Bojan Skrchevski
*
*
* Given the root node of a binary tree, can we also determine if it is also a Binary Search Tree?
*
*
* Originally posted on HackerRank: https://www.hackerrank.com/challenges/ctci-is-binary-search-tree/problem
*
*
*
* is_bst_check() traverses down the tree keeping track of the narrowing min and max allowed values as it goes,
* looking at each node only once. The initial values for min and max should be INT_MIN and INT_MAX 
*  — they narrow from there.
*
*/


public bool IsBinarySearchTree(Node<T> root) {
	return is_bst_check(node, Integer.MIN_VALUE, Integer.MAX_VALUE);
}

private bool is_bst_check(Node<T> root, int min, int max) {
	if (root == null)
		return true;

	if (root.data < min || root.data > max)
		return false;

	return (is_bst_check(root.left, min, root.data - 1) && is_bst_check(root.right, root.data + 1, max));
}
