package com.mashibing.tank;

import java.awt.Frame;
import java.awt.Graphics;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class TankFrame extends Frame {
	int x=100;int y=100;
	public TankFrame() {
		setSize(800,600);//设置窗口的大小
		setResizable(false);//是否可以改变窗口的大小
		setTitle("tank war");
		setVisible(true);//显示窗口
		//添加一个window的监听器
		//Adapter可以看作是Listener的一个子类
		addWindowListener(new WindowAdapter() {

			@Override
			public void windowClosing(WindowEvent e) {
				// TODO Auto-generated method stub
				//super.windowClosing(e);
				System.exit(0);
			}
			
		});
	}
	@Override
	public void paint(Graphics g) {
		g.fillRect(x, y, 10, 10);
		x+=20;
		y+=20;
	}
}
