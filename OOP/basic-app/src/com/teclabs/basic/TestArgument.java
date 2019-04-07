package com.teclabs.basic;

public class TestArgument {

	public static void main(String[] args) {
		int len = args.length;
		if (len == 0) {
			System.out.println("Thank you");
		} else {
			for (int i = 0; i < len; i++) {
				System.out.println("Hello " + args[i]);
			}
		}

	}
}
