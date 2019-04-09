package com.teclabs.chapter;

public class Chapter1 {

	public static void main(String[] args) {
		System.out.println("I sanal");
		System.out.println("The world");
		int x = 3;
		String []wordListOne={"24/7","multi-Taier","30,200 foot","B-to-B","win-win","front-end"};
		String[] wordListtwo={"emposed","sticky","value-add","oriented","centric","distributed","clustered","braanded"};
		String []wordLoistThree={"process", "tippingpoint", "solution", "architecture", "core competency","strategy", "mindshare", "portal","space", "vision","paradigm", "mission"};
		
		int oneLength = wordListOne.length;
		 int twoLength = wordListtwo.length;
		 int threeLength = wordLoistThree.length;
		 
		 int rand1 = (int) (Math.random() * oneLength);
		 int rand2 = (int) (Math.random() * twoLength);
		 int rand3 = (int) (Math.random() * threeLength);
		 String phrase = wordListOne[rand1] + " " +		 wordListtwo[rand2] + " "+ wordLoistThree[rand3];
		 
		 System.out.println("What we need is a " + phrase);
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
