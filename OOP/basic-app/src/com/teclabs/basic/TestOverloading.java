package com.teclabs.basic;

public class TestOverloading {

	public static void main(String[] args) {
		TestOverloading to = new TestOverloading();
		char[] a = { 'a', 'b', 'c' };

		System.err.println("hi String ");
		System.err.println('a');
		System.err.println(47.55f);
		System.err.println(15);
		System.err.println(to);
		System.err.println(false);
		System.err.print(1.55);
		System.err.println(a);
		System.err.print(145l);
		System.err.println();
		printThis(10);
		printThis(10.55f);
		printThis(445.666);
		printThis("swabhav");
		printThis('a');

	}

	static void printThis(int a) {
		System.err.print("This int over loading ");
		System.err.println(a);
	}

	static void printThis(float a) {
		System.err.print("This float over loading ");
		System.err.println(a);
	}

	static void printThis(double a) {
		System.err.print("This double over loading ");
		System.err.println(a);
	}

	static void printThis(String a) {
		System.err.print("This String over loading ");
		System.err.println(a);
	}

	static void printThis(char a) {
		System.err.print("This char over loading ");
		System.err.println(a);
	}

}
