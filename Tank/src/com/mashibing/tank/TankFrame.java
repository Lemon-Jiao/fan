package com.mashibing.tank;

import java.awt.Frame;
import java.awt.Graphics;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class TankFrame extends Frame {
	int x=100;int y=100;
	public TankFrame() {
		setSize(800,600);//���ô��ڵĴ�С
		setResizable(false);//�Ƿ���Ըı䴰�ڵĴ�С
		setTitle("tank war");
		setVisible(true);//��ʾ����
		//���һ��window�ļ�����
		//Adapter���Կ�����Listener��һ������
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
