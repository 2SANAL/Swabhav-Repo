package com.teclabs.chapter;

public class Chapter1 {

	public static void main(String[] args) {
		System.out.println("I sanal");
		System.out.println("The world");
		int x = 3;
		String name = "Dirk";
		x = x * 17;
		System.out.println("X is " + x);
		double d = Math.random();
		System.out.println(d);
		while (x > 12) {
			x = x - 1;
		}
		for (int i = 0; i < 10; i = i + 1) {
			System.out.println("i is now " + i);
		}
		if (x == 20) {
			System.out.println("X is 20 ");
		} else {
			System.out.println("x isnot 20");
		}
		if ((x < 3) & (name.equals("Dirk"))) {
			System.out.println("Gently");
		}
		System.out.println("this line runs no matter what");
		int weight;

	}

}
