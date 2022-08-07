import Head from 'next/head'
import { LayoutProps } from '../models/LayoutProps';
import Footer from './footer'
import styles from './Layout.module.css';

export default function Layout({ children }: LayoutProps) {
  return (
    <div className={styles.container}>
      <Head>
        <title>TIL:TodayILearned</title>
        <meta name="description" content="A tool to help refresh your memory" />
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <main>{children}</main>
      <Footer />
    </div>
  )
}